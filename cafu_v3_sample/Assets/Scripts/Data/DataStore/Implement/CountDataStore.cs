using Data.Repository.Interface;
using UnityEngine;

namespace Data.DataStore
{
    public class CountDataStore : ICountDataStore
    {
        public int GetCount()
        {
            return PlayerPrefs.GetInt("Count", 0);
        }

        public void SetCount(int value)
        {
            PlayerPrefs.SetInt("Count", value);
        }
    }
}