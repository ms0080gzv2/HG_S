using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SaveSystemTutorial
{
    public static class SaveSystem
    {
        public static void SaveByJson(string saveFileName, object data)
        {
            var json = JsonUtility.ToJson(data);
            string path = Path.Combine(Application.persistentDataPath, saveFileName);


            try
            {
                File.WriteAllText(path,json);
                Debug.Log($"susscessfully save data to {path}.*");

            }
            catch (System.Exception exception)
            {                
                Debug.LogError($"Failed save data to {path}. \n{exception}");
            }
            
        }

        public static T LoadFromJson<T>(string saveFileName)
        {
            string path = Path.Combine(Application.persistentDataPath, saveFileName);

            try
            {
                var json =  File.ReadAllText(path);
                var data = JsonUtility.FromJson<T>(json);
                return data;
            }
            catch (System.Exception exception)
            {           
                Debug.LogError($"Failed Load data from {path}. \n{exception}");
                return default;
            }

        }

        public static void DeleteSaveFile(string saveFileName)
        {
            string path = Path.Combine(Application.persistentDataPath, saveFileName);

            try
            {
                File.Delete(path);
            }
            catch (System.Exception exception)
            {               
                Debug.LogError($"Failed delete data {path}. \n{exception}");
            }


        }
    }
}
