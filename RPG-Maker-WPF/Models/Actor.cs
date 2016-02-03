﻿using System.Xml.Serialization;

namespace RPG_Maker_WPF.Models
{
	/// <summary>
	/// Represents a (theoretically) playable character.
	/// </summary>
	[XmlRoot(ElementName = "Actor")]
	public class Actor
	{
		#region Properties

		/// <summary>
		/// The name of this actor.
		/// </summary>
		public string Name
		{
			get { return _name; }
		  set { _name = value; }
		}
		private string _name;

		/// <summary>
		/// The second name of this actor.
		/// </summary>
		public string SecondName
		{
			get { return _secondName; }
			set { _secondName = value; }
		}
		private string _secondName;

		public string Description
		{
			get { return _description; }
			set { _description = value; }
		}
		private string _description;

		/// <summary>
		/// The initial level of this actor.
		/// </summary>
		public int InitialLevel
		{
			get { return _initialLevel; }
			set { _initialLevel = value; }
		}
		private int _initialLevel;

		/// <summary>
		/// The maximum level of this actor.
		/// </summary>
		public int MaxLevel
		{
			get { return _maxLevel; }
			set
			{ _maxLevel = value; }
		}
		private int _maxLevel;

		#endregion Properties
	}
}