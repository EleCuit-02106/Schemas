// This file is auto-generated from IdDomain.toml
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace MD.System
{

    public class MasterIdDomainRepository : du.Cmp.Singleton<MasterIdDomainRepository>
    {
        #region public
        public bool IsExist(int id) => m_data.ContainsKey(id);
        public MasterIdDomain At(int id) => m_data[id];
        public IReadOnlyDictionary<int, MasterIdDomain> Data { get => m_data; }
        #endregion

        #region field
        private Dictionary<int, MasterIdDomain> m_data;
        #endregion

        #region private function
        public async UniTask Load()
        {
            if (m_data != null) { return; }
            m_data = new Dictionary<int, MasterIdDomain>();
            string assetAddress = global::EC.Adds.MasterJson + "MasterIdDomain" + ".json";
            var task = du.File.FileUtils.LoadTextFileFull(assetAddress);
            string mdRecordsAsJson = await task;
            var mdList = UnityEngine.JsonUtility.FromJson<MasterIdDomainList>(mdRecordsAsJson);
            foreach (var record in mdList.data)
            {
                m_data.Add(record.Id, record);
            }
        }
        #endregion
    }

}

