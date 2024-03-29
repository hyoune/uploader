﻿using UnityEngine;
using System.Collections;
using System;

public abstract class Action_2 : MonoBehaviour
{
	public virtual bool ExecuteAction(GameObject other)
	{
		//the return value indicates if the action has been successful
		//some actions always return true
		return true;
	}
}
