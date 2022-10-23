// This file is auto-generated from IdDomain.toml
using System;
using UnityEngine;

namespace MD.System
{

    [Serializable]
    public sealed class MasterIdDomain
    {
        #region property
        public int Id { get => id; }
        public int Begin { get => begin; }
        public int End { get => end; }
        public string Category { get => category; }
        public string Table { get => table; }
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

