using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinFetcher : MonoBehaviour
{
    [SerializeField] Text gems;
    Text txt;
    // Start is called before the first frame update
    void Start()
    {
        txt = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Coins: " + (InventoryManager.coin + InventoryManager.coinContainer).ToString();
        gems.text = "Gems: " + (InventoryManager.gem + InventoryManager.gemContainer).ToString();

    }
}
