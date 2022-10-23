// This file is auto-generated from IdDomain.toml
using System;
using UnityEngine;

namespace MD.System
{

    [Serializable]
    public sealed class MasterIdDomain
    {
        #region property
        public int Id => id;
        public int Begin => begin;
        public int End => end;
        public string Category => category;
        public string Table => table;
        #endregion

        #region field
        [SerializeField] private int id;
        [SerializeField] private int begin;
        [SerializeField] private int end;
        [SerializeField] private string category;
        [SerializeField] private string table;
        #endregion

        #region ctor
        public MasterIdDomain(
            int id,
            int begin,
            int end,
            string category,
            string table)
        {
            this.id = id;
            this.begin = begin;
            this.end = end;
            this.category = category;
            this.table = table;
        }
        #endregion
    }

    [Serializable]
    public sealed class MasterIdDomainList
    {
        public MasterIdDomain[] data;
    }

}

