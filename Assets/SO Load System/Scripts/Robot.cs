using UnityEngine;
using UnityEngine.UI;

public class Robot : MonoBehaviour
{
    [SerializeField] private Text robotName;
    [SerializeField] private Image robotImage;

    private void Start()
    {
        Setup(RobotConfig.Value.RobotName, RobotConfig.Value.RobotColor);
    }

    private void Setup(string name, Color imageColor)
    {
        robotName.text = name;
        robotImage.color = imageColor;
    }
}
