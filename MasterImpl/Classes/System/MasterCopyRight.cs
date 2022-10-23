// This file is auto-generated from CopyRight.toml
using System;
using UnityEngine;

namespace MD.System
{

    [Serializable]
    public sealed class MasterCopyRight
    {
        #region property
        public int Id => id;
        public int CopyRightVersion => copyRightVersion;
        public int OpenedAt => openedAt;
        public int ClosedAt => closedAt;
        public string Line01 => line01;
        public string Line02 => line02;
        public string Line03 => line03;
        #endregion

        #region field
        [SerializeField] private int id;
        [SerializeField] private int copyRightVersion;
        [SerializeField] private int openedAt;
        [SerializeField] private int closedAt;
        [SerializeField] private string line01;
        [SerializeField] private string line02;
        [SerializeField] private string line03;
        #endregion

        #region ctor
        public MasterCopyRight(
            int id,
            int copyRightVersion,
            int openedAt,
            int closedAt,
            string line01,
            string line02,
            string line03)
        {
            this.id = id;
            this.copyRightVersion = copyRightVersion;
            this.openedAt = openedAt;
            this.closedAt = closedAt;
            this.line01 = line01;
            this.line02 = line02;
            this.line03 = line03;
        }
        #endregion
    }

    [Serializable]
    public sealed class MasterCopyRightList
    {
        public MasterCopyRight[] data;
    }

}

