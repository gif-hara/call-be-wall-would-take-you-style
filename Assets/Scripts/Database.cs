using System.Collections.Generic;
using UnityEngine;

namespace HK.Soramimi
{
    [CreateAssetMenu()]
    public sealed class Database : ScriptableObject
    {
        [SerializeField]
        private List<Data> database;

        public List<Data> Get
        {
            get { return this.database; }
        }
        
        public class Data
        {
            [SerializeField]
            private string key;

            [SerializeField]
            private string value;
            
            public string Key { get { return key; } }

            public string Value { get { return value; } }
        }
    }
}
