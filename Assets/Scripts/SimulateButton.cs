using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SimulateButton : MonoBehaviour
{

	public GameObject PlayImage;
	public GameObject StopImage;
	public TextMeshProUGUI Text;

	public void SetIsRunning(bool isRunning)
	{
		PlayImage.SetActive(!isRunning);
		StopImage.SetActive(isRunning);

		Text.text = isRunning ? "정지" : "재생";
	}
}
