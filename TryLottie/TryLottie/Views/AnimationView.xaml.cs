using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TryLottie.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AnimationView : ContentPage
	{
		public AnimationView ()
		{
			InitializeComponent ();
		}

	    public void Play_Heart(object sender, EventArgs eventArgs)
	    {
	        AnimationViews.IsVisible = true;
	        AnimationViews.Play();
	        AnimationViews.Loop = true;
	    }

	    public void Stop_Heart(object sender, EventArgs eventArgs)
	    {
	        AnimationViews.Loop = false;
            AnimationViews.IsVisible = false;
	    }

    }
}