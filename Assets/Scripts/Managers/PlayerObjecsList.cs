using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerObjecsList : MonoBehaviour {
    private static PlayerObjecsList instance;

    public static PlayerObjecsList GetInstance () {
        return instance;
    }

    private List<GameObject> list;
    private GameObject me;

    private void Awake () {
        if (instance != null) {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }

    private void Start () {
        UpdateList();
    }

    public IReadOnlyList<GameObject> GetList() {
        return list;
    }

    public List<string> GetNameList() {
        var nameList = new List<string>();
        foreach (GameObject obj in list) {
            var nameplate = obj.GetComponent<CharacterNameplate>();
            if (nameplate == null) {
                continue;
            }
            nameList.Add(nameplate.GetName());
        }
        return nameList;
    }

    public void UpdateList () {
        int cnt = transform.childCount;
        list = new List<GameObject>();
        for (int i = 0; i < cnt; i++) {
            GameObject obj = transform.GetChild(i).gameObject;
            if (!obj.activeSelf) {
                continue;
            }
            list.Add(obj);
        }
    }

    public GameObject GetMyPlayer () {
        if (me != null) {
            return me;
        }

        foreach (GameObject obj in list) {
            if (obj.GetComponent<PlayerInputController>() == null) {
                continue;
            }
            me = obj;
            break;
        }

        return me;
    }
}
