using UnityEngine;
using UnityEditor;
using System.Collections;

public class JCShortcuts : MonoBehaviour {

	// Use this for initialization
	


	[MenuItem("JCShortcuts/Rotate 90 degrees on Y Axis &e")]
	private static void Rotate90Y()
	{
		foreach(Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Rotate Transform");
			t.Rotate (new Vector3 (0, 90, 0));
		}

	}

	[MenuItem("JCShortcuts/Rotate -90 degrees on Y Axis &q")]
	private static void RotateNegative90Y()
	{
		foreach(Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Rotate Transform");
			t.Rotate (new Vector3 (0, 90, 0));
		}
	}

	[MenuItem("JCShortcuts/Move 1 on X Axis &w")]
	private static void MoveOneOnX()
	{
		foreach (Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Move Transform");
			Vector3 newPos = t.position;
			newPos.x += 1;
			t.position = newPos;

			SnapObject(t);

		}
	}

	[MenuItem("JCShortcuts/Move -1 on X Axis &s")]
	private static void MoveNegativeOneOnX()
	{
		foreach (Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Move Transform");
			Vector3 newPos = t.position;
			newPos.x -= 1;
			t.position = newPos;

			SnapObject(t);

		}
	}

	[MenuItem("JCShortcuts/Move 1 on Z Axis &a")]
	private static void MoveOneOnZ()
	{
		foreach (Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Move Transform");
			Vector3 newPos = t.position;
			newPos.z += 1;
			t.position = newPos;

			SnapObject(t);

		}
	}
	
	[MenuItem("JCShortcuts/Move -1 on Z Axis &d")]
	private static void MoveNegativeOneOnZ()
	{
		foreach (Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Move Transform");
			Vector3 newPos = t.position;
			newPos.z -= 1;
			t.position = newPos;

			SnapObject(t);
		}
	}

	[MenuItem("JCShortcuts/Reset to 0,0,0 &r")]
	private static void ResetToZero()
	{
		foreach (Transform t in Selection.transforms) {
			Undo.RecordObject (t, "Reset Transform");
			t.position = Vector3.zero;
		}
	}

	
	private static void SnapObject(Transform t) {
		Vector3 p = t.position;
		p.x = Mathf.Round (p.x * 2) / 2;
		p.z = Mathf.Round (p.z * 2) / 2;
		t.position = p;
	}
}
