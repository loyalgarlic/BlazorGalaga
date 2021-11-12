using Microsoft.JSInterop;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;

namespace BlazorGalaga.Services
{
    public class Ranker
    {
        public string NickName { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }

    public class RankService
    {
        private readonly IJSRuntime _jsRuntime;
        private readonly ISyncLocalStorageService _localStorage;
        private readonly NavigationManager _navigationManager;
        public RankService(IJSRuntime js, ISyncLocalStorageService ls, NavigationManager nm)
        {
            _jsRuntime = js;
            _localStorage = ls;
            _navigationManager = nm;
        }

        public int GetOfflineHighScore()
        {
            var json = _localStorage.GetItem<string>("LocalRank");
            if (json == null)
                return 0;
            var rankers = JsonConvert.DeserializeObject<IEnumerable<Ranker>>(json).ToList();
            return rankers[0].Score;
        }

        public async Task OpenSavePage(int score)
        {
            var scoreStr = StringUtil.CryptFromInt(score);
            await _jsRuntime.InvokeAsync<object>("open", $"/Save/{scoreStr}", "_blank");
        }

        public List<Ranker> GetRankers()
        {
            var json = _localStorage.GetItem<string>("LocalRank");
            if (json == null)
                return null;
            return JsonConvert.DeserializeObject<IEnumerable<Ranker>>(json).ToList();
        }

        public async Task SaveOfflineAsync(int score)
        {
            string nickName = await _jsRuntime.InvokeAsync<string>("prompt", "your nickname:");
            if (string.IsNullOrEmpty(nickName))
                return;
            var rankers = GetRankers();
            if (rankers != null)
            {
                var oldRanker = rankers.Find(m => m.NickName == nickName);
                if (oldRanker != null)
                {
                    if (score > oldRanker.Score)
                        oldRanker.Score = score;
                }
                else
                {
                    rankers.Add(new Ranker { NickName = nickName, Score = score, Date = DateTime.Now });
                }
            }
            else
            {
                rankers = new List<Ranker>();
                rankers.Add(new Ranker { NickName = nickName, Score = score, Date = DateTime.Now });
            }

            string json = JsonConvert.SerializeObject(rankers, Formatting.Indented);
            _localStorage.SetItem("LocalRank", json);
            _navigationManager.NavigateTo("/OfflineRank");
        }
    }
}
