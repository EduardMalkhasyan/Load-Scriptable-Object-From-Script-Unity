using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerData")]
public class PlayerConfig : SOLoader<PlayerConfig>
{
    [field: SerializeField] public string PlayerName { get; private set; }
    [field: SerializeField] public Color PlayerColor { get; private set; }
}
