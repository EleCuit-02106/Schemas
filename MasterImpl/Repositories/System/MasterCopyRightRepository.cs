// This file is auto-generated from CopyRight.toml
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace MD.System
{

    public class MasterCopyRightRepository : du.Cmp.Singleton<MasterCopyRightRepository>
    {
        #region public
        public bool IsExist(int id) => m_data.ContainsKey(id);
        public MasterCopyRight At(int id) => m_data[id];
        public IReadOnlyDictionary<int, MasterCopyRight> Data { get => m_data; }
        #endregion

        #region field
        private Dictionary<int, MasterCopyRight> m_data;
        #endregion

        #region private function
        public async UniTask Load()
        {
            if (m_data != null) { return; }
            m_data = new Dictionary<int, MasterCopyRight>();
            string assetAddress = global::EC.Adds.MasterJson + "MasterCopyRight" + ".json";
            var task = du.File.FileUtils.LoadTextFileFull(assetAddress);
            string mdRecordsAsJson = await task;
            var mdList = UnityEngine.JsonUtility.FromJson<MasterCopyRightList>(mdRecordsAsJson);
            foreach (var record in mdList.data)
            {
                m_data.Add(record.Id, record);
            }
        }
        #endregion
    }

}

