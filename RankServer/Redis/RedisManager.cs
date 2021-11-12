using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;
using RankServer.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace RankServer.Redis
{
    public class RedisManager
    {
        static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

        public static void AddRankersFromDb()
        {
            var configuration = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();
            var options = new DbContextOptionsBuilder<RankDbContext>()
                                .UseSqlite(configuration.GetConnectionString("RankDbConnection")).Options;
            using var dbContext = new RankDbContext(options);
            var rankers = dbContext.Rankers.AsQueryable().AsNoTracking().ToList();
            foreach(var ranker in rankers)
            {
                AddRanker(ranker.NickName, ranker.Score, ranker.Date);
            }
        }
        
        public static void AddRanker(string nickname, int score, DateTime date)
        {
            IDatabase db = redis.GetDatabase();
            db.SortedSetAdd("ranker", nickname, score);
            db.StringSet(nickname, date.ToString());
        }

        public static List<Ranker> GetTopRanker()
        {
            IDatabase db = redis.GetDatabase();
            SortedSetEntry[] list = db.SortedSetRangeByRankWithScores("ranker", 0, 100, Order.Descending);
            List<Ranker> rankers = new List<Ranker>();
            for(int i = 0; i < list.Length; ++i)
            {
                string nickname = list[i].Element;
                int score = (int)list[i].Score;
                string datestr = db.StringGet(nickname);
                DateTime date = DateTime.Parse(datestr);
                rankers.Add(new Ranker { NickName = nickname, Score = score, Date = date });
            }
            return rankers;
        }

        public static long GetRank(string nickname)
        {
            IDatabase db = redis.GetDatabase();
            long? rank = db.SortedSetRank("ranker", nickname, Order.Descending);
            if (rank.HasValue)
                return rank.Value;
            return -1;
        }
    }
}
