using UnityEngine;

[CreateAssetMenu(fileName = "RobotData", menuName = "ScriptableObjects/RobotData")]
public class RobotConfig : SOLoader<RobotConfig>
{
    [field: SerializeField] public string RobotName { get; private set; }
    [field: SerializeField] public Color RobotColor { get; private set; }
}
