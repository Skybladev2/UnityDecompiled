using System;
using UnityEngine;
namespace UnityEditor.Animations
{
	public struct ChildAnimatorStateMachine
	{
		private AnimatorStateMachine m_StateMachine;
		private Vector3 m_Position;
		public AnimatorStateMachine stateMachine
		{
			get
			{
				return this.m_StateMachine;
			}
			set
			{
				this.m_StateMachine = value;
			}
		}
		public Vector3 position
		{
			get
			{
				return this.m_Position;
			}
			set
			{
				this.m_Position = value;
			}
		}
	}
}
