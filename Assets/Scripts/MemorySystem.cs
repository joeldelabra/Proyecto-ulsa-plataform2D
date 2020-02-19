using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Platform2DUtils.MemorySystem
{
   public class MemorySystem
   {
       public static void SaveData(GameData GameData) 
       {
           string path = $"{Application.persistentDataPath}/myGame.data";
           BinaryFormatter bf = new BinaryFormatter();
           FileStream file = File.Create (path);
           string json = JsonUtility.ToJson(gameData);
           bf.Serialize(file,json);
           file.Close();
            Debug.log(path);
       }



   }

}
