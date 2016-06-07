using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class SceneController : MonoBehaviour {

	public GameObject sunLight;

	public GameObject[] buttons;
	public Color btnActiveColor;

	public GameObject[] listRain;
	public GameObject[] listSnow;
	public GameObject[] listHail;

	private string activeType = "rain";
	private string activeStrength = "soft";
	
	public GameObject activeBtnType;
	public GameObject activeBtnStrength;
	public GameObject activeBtnTime;


	void Awake()
	{
		activeBtnType.GetComponent<Image>().color = btnActiveColor;
		activeBtnStrength.GetComponent<Image>().color = btnActiveColor;
		activeBtnTime.GetComponent<Image>().color = btnActiveColor;
	}

	void UpdateActiveSystem()
	{
		int strengthIndex = 0;

		switch(activeStrength)
		{
			case "soft": strengthIndex = 0; break;
			case "medium": strengthIndex = 1; break;
			case "heavy": strengthIndex = 2; break;
		}

		// disable first
		listRain[0].SetActive(false);
		listRain[1].SetActive(false);
		listRain[2].SetActive(false);
		listSnow[0].SetActive(false);
		listSnow[1].SetActive(false);
		listSnow[2].SetActive(false);
		listHail[0].SetActive(false);
		listHail[1].SetActive(false);
		listHail[2].SetActive(false);

		if ( activeType=="rain" ) { listRain[strengthIndex].SetActive(true); }
		if ( activeType=="snow" ) { listSnow[strengthIndex].SetActive(true); }
		if ( activeType=="hail" ) { listHail[strengthIndex].SetActive(true); }

	}

	
	public void SetRain()
	{
		activeType = "rain";
		UpdateActiveSystem();

		activeBtnType.GetComponent<Image>().color = Color.black;
		activeBtnType = buttons[0];
		activeBtnType.GetComponent<Image>().color = btnActiveColor;
	}
	
	public void SetSnow()
	{
		activeType = "snow";
		UpdateActiveSystem();
		
		activeBtnType.GetComponent<Image>().color = Color.black;
		activeBtnType = buttons[1];
		activeBtnType.GetComponent<Image>().color = btnActiveColor;
	}
	
	public void SetHail()
	{
		activeType = "hail";
		UpdateActiveSystem();
		
		activeBtnType.GetComponent<Image>().color = Color.black;
		activeBtnType = buttons[2];
		activeBtnType.GetComponent<Image>().color = btnActiveColor;
	}

	
	public void SetSoft()
	{
		activeStrength = "rain";
		UpdateActiveSystem();
		
		activeBtnStrength.GetComponent<Image>().color = Color.black;
		activeBtnStrength = buttons[3];
		activeBtnStrength.GetComponent<Image>().color = btnActiveColor;
	}
	
	public void SetMedium()
	{
		activeStrength = "medium";
		UpdateActiveSystem();
		
		activeBtnStrength.GetComponent<Image>().color = Color.black;
		activeBtnStrength = buttons[4];
		activeBtnStrength.GetComponent<Image>().color = btnActiveColor;
	}
	
	public void SetHeavy()
	{
		activeStrength = "heavy";
		UpdateActiveSystem();
		
		activeBtnStrength.GetComponent<Image>().color = Color.black;
		activeBtnStrength = buttons[5];
		activeBtnStrength.GetComponent<Image>().color = btnActiveColor;
	}


	public void SetDay()
	{
		sunLight.GetComponent<Light>().intensity = 2.0f;
		
		activeBtnTime.GetComponent<Image>().color = Color.black;
		activeBtnTime = buttons[6];
		activeBtnTime.GetComponent<Image>().color = btnActiveColor;
	}

	public void SetNight()
	{
		sunLight.GetComponent<Light>().intensity = 0.8f;
		
		activeBtnTime.GetComponent<Image>().color = Color.black;
		activeBtnTime = buttons[7];
		activeBtnTime.GetComponent<Image>().color = btnActiveColor;
	}


}
