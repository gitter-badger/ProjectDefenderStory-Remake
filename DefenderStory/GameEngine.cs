using DefenderStory.Api;
using DefenderStory.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DxLibDLL.DX;

namespace DefenderStory
{
	class GameEngine : IGameEngine
	{
		private static GameEngine instance;

		public SceneRegistry Scenes => new SceneRegistry();

		private GameEngine()
		{

		}

		public void OnInit()
		{

		}

		public void Quit()
		{
			DxLib_End();
			Environment.Exit(0);
		}

		public Scene CurrentScene
		{
			get; private set;
		}

		public void SwitchScene(string name)
		{
			
		}


		public static GameEngine Instance
		{
			get
			{
				if (instance == null)
					instance = new GameEngine();
				return instance;
			}
		}

		public long Tick
		{
			get; set;
		}


	}
}
