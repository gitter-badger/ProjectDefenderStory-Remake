using DefenderStory.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DefenderStory.Scenes
{
	class SceneRegistry
	{
		readonly Dictionary<string, Type> items = new Dictionary<string, Type>();

		public SceneRegistry()
		{
			
			// --- 組み込みの Scene を登録
			
			// ---

		}

		public Type this[string key]
		{
			get
			{
				if (!items.ContainsKey(key))
					throw new DefenderStoryException(string.Format("{0} という名前の Scene は，登録されていません．", key));
				return items[key];
			}
			set
			{
				if (!typeof(Scene).IsAssignableFrom(value))
					throw new DefenderStoryException(string.Format("登録しようとした {0} クラスは Sceneではありません．", value.Name));
				if (items.ContainsKey(key))
					return;
				items[key] = value;
			}
		}

		public Scene CreateInstance(string key) => (Scene)Activator.CreateInstance(this[key]);


		
	}
}
