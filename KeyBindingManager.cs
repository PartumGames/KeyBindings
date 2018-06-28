using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindingManager : MonoBehaviour {

    private List<string> keys;
    public List<Dropdown> dropdowns = new List<Dropdown>();

    public KeyCode jumpKey;
    public KeyCode pauseKey;
    public KeyCode inventoryKey;

    void Start()
    {
        keys = new List<string> { "Space", "A", "B", "C", "D", "I", "S", "M" };
        for (int i = 0; i < dropdowns.Count; i++)
        {
            dropdowns[i].AddOptions(keys);
        }

        PlayerPrefs.SetString("jumpPrefs", "M");
        LoadPrefabs();
    }

  
    private void LoadPrefabs()
    {
        jumpKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("jumpPrefs"));
        Select_Key(dropdowns[0], jumpKey.ToString());

        pauseKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("pausePrefs"));
        Select_Key(dropdowns[1], pauseKey.ToString());

        inventoryKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), PlayerPrefs.GetString("inventoryPrefs"));
        Select_Key(dropdowns[2], inventoryKey.ToString());

    }

    private void Select_Key(Dropdown _dropdown, string _s)
    {
        for (int i = 0; i < keys.Count; i++)
        {
            if(_s == keys[i])
            {
                _dropdown.value = i;
            }
        }
    }

    public void ChangeJumpKey(int id)
    {
        jumpKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), keys[id]);
        PlayerPrefs.SetString("jumpPrefs", keys[id]);
    }

    public void ChangePauseKey(int id)
    {
        pauseKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), keys[id]);
        PlayerPrefs.SetString("pausePrefs", keys[id]);
    }

    public void ChangeInventoryKey(int id)
    {
        inventoryKey = (KeyCode)System.Enum.Parse(typeof(KeyCode), keys[id]);
        PlayerPrefs.SetString("inventoryPrefs", keys[id]);
    }

}
