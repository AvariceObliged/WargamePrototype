using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wargame.Client.Pieces
{
    public class GameUnit : MonoBehaviour
    {
        [SerializeField] private List<GamePiece> _ownedPieces;
    }
}