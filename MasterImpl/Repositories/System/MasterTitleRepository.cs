// This file is auto-generated from Title.toml
using System.Collections.Generic;
using Cysharp.Threading.Tasks;

namespace MD.System
{

    public class MasterTitleRepository : du.Cmp.Singleton<MasterTitleRepository>
    {
        #region public
        public bool IsExist(int id) => m_data.ContainsKey(id);
        public MasterTitle At(int id) => m_data[id];
        public IReadOnlyDictionary<int, MasterTitle> Data { get => m_data; }
        #endregion

        #region field
        private Dictionary<int, MasterTitle> m_data;
        #endregion

        #region private function
        public async UniTask Load()
        {
            if (m_data != null) { return; }
            m_data = new Dictionary<int, MasterTitle>();
            string assetAddress = global::EC.Adds.MasterJson + "MasterTitle" + ".json";
            var task = du.File.FileUtils.LoadTextFileFull(assetAddress);
            string mdRecordsAsJson = await task;
            var mdList = UnityEngine.JsonUtility.FromJson<MasterTitleList>(mdRecordsAsJson);
            foreach (var record in mdList.data)
            {
                m_data.Add(record.Id, record);
            }
        }
        #endregion
    }

}

