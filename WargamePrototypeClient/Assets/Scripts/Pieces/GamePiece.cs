using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Wargame.Client.Statblocks;

namespace Wargame.Client.Pieces
{
    public class GamePiece : MonoBehaviour
    {
        [SerializeField] private GameObject _model;
        [SerializeField] private GamePieceStatblock _internalStatblock;
        [SerializeField] public GamePieceStatblock TrackedStatblock;
    }
}