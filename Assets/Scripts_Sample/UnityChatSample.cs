using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEditor.PackageManager;

namespace UnityChat.Sample {

    public class UnityChatSample : MonoBehaviour {

        void Start() {

            const string DOMAIN = "http://localhost:5294";
            string id = UnityEditor.CloudProjectSettings.userId;
            string userName = UnityEditor.CloudProjectSettings.userName;
            Debug.Log(id + " : " + userName);

            byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes("Hello, UnityChat!");
            UnityWebRequest request = UnityWebRequest.Put(DOMAIN + "/chat/send", bodyRaw);
            var res = request.SendWebRequest();
            while (!res.isDone) {
            }
            if (request.responseCode != 200) {
                Debug.LogError("Error: " + request.responseCode);
            }

        }

        void Update() {

        }

    }
}
