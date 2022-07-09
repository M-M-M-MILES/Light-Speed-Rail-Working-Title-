using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleController : StateMachine
{
	public CameraRig cameraRig;
	public Board board;
	public LevelData levelData;
	public Transform tileSelectionIndicator;
	public Point pos;
	public Tile currentTile { get { return board.GetTile(pos); } }
	public GameObject heroPrefab;
	public Unit currentUnit;

	void Start()
	{
		ChangeState<InitBattleState>();
	}
}