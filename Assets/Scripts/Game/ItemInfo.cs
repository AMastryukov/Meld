using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemInfo : MonoBehaviour {

  public string itemInfo;
  public Text itemInformationText;

  private void Start()
  {
    itemInformationText.gameObject.SetActive(false);
  }

  private void OnMouseEnter()
  {
    if (GetComponent<ItemPickup>().inInventory)
    {
      itemInformationText.text = itemInfo;
      itemInformationText.gameObject.SetActive(true);
    }
  }

  private void OnMouseExit()
  {
    itemInformationText.gameObject.SetActive(false);
  }
}
