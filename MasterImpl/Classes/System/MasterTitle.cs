// This file is auto-generated from Title.toml
using System;
using UnityEngine;

namespace MD.System
{

    [Serializable]
    public sealed class MasterTitle
    {
        #region property
        public int Id => id;
        public int TitleVersion => titleVersion;
        public int Priority => priority;
        public int OpenedAt => openedAt;
        public int ClosedAt => closedAt;
        #endregion

        #region field
        [SerializeField] private int id;
        [SerializeField] private int titleVersion;
        [SerializeField] private int priority;
        [SerializeField] private int openedAt;
        [SerializeField] private int closedAt;
        #endregion

        #region ctor
        public MasterTitle(
            int id,
            int titleVersion,
            int priority,
            int openedAt,
            int closedAt)
        {
            this.id = id;
            this.titleVersion = titleVersion;
            this.priority = priority;
            this.openedAt = openedAt;
            this.closedAt = closedAt;
        }
        #endregion
    }

    [Serializable]
    public sealed class MasterTitleList
    {
        public MasterTitle[] data;
    }

}

