using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefenderStory.Api
{
    public abstract class Scene
    {
		public long Tick { get; protected set; }

		public virtual void OnInit()
		{

		}

		public virtual void OnUpdate()
		{

		}

		public virtual void OnDestroy()
		{

		}

		public virtual void OnDraw(int GrHandle)
		{
			
		}

    }

	public interface IGameEngine
	{
		long Tick { get; }
		Scene CurrentScene { get; }
	}

	public interface IGraphics
	{
		
	}

}