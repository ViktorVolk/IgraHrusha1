using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopManeger : MonoBehaviour
{
    private int index;
    private int money;
    [SerializeField] private SetSkin SetSkin;
    [SerializeField] private Text Money;
    [SerializeField] private int[] prices;
    [SerializeField] private Text Price;
    public GameObject BackSound;
    public GameObject Butt;

    public void SkinBack()
    {
        Instantiate(Butt, transform.position, Quaternion.identity);
        if (index > 0)
        {
            index = index - 1;
        }
        else
            index = 2;
        SetSkin.UpdateSkin(index);
        Price.text = prices[index].ToString();
    }

    public void SkinNext()
    {
        Instantiate(Butt, transform.position, Quaternion.identity);
        if (index < 2)
        {
            index = index + 1;
        }
        else
            index = 0;
        SetSkin.UpdateSkin(index);
        Price.text = prices[index].ToString();
    }

    public void SceneHome()
    {
        Instantiate(Butt, transform.position, Quaternion.identity);
        SceneManager.LoadScene(0);
    }

    void Start()
    {
        Instantiate(BackSound, transform.position, Quaternion.identity);
        index = SetSkin.NumberSkin;
        money = PlayerPrefs.GetInt("ALLScore");
        Money.text = money.ToString();
        Price.text = prices[index].ToString();
    }


    public void BuySkin()
    {
        if (PlayerPrefs.GetInt("Skin" + index.ToString()) == 1)
            PlayerPrefs.SetInt("index", index);
        else if (PlayerPrefs.GetInt("Skin" + index.ToString()) == 0)
        {
            if ((money) >= (prices[index]))
            {
                money = money - prices[index];
                PlayerPrefs.SetInt("ALLScore", money);
                PlayerPrefs.SetInt("Skin" + index.ToString(),1);
            }
        }
    }

    public void Delete()
    {
        PlayerPrefs.SetInt("Skin" + index.ToString(), 0);
    }

    void Update()
    {
        Money.text = money.ToString();
        if (PlayerPrefs.GetInt("Skin" + index.ToString()) == 0)
            if (money >= prices[index])
            {
                Price.color = Color.green;
                Price.text = prices[index].ToString();
            }
            else
            {
                Price.color = Color.red;
                Price.text = prices[index].ToString();
            }
        else
        {
            Price.color = Color.yellow;
            Price.text = "OK";
        }
    }
}
