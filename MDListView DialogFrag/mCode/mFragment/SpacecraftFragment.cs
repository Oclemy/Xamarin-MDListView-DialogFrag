using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MDListView_DialogFrag.mCode.mFragment
{
    public class SpacecraftFragment : DialogFragment
    {
        private TextView nameTxt;
        private ImageView img;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View rootView = inflater.Inflate(Resource.Layout.SpacecraftDetail, container, false);

            nameTxt = rootView.FindViewById<TextView>(Resource.Id.nameDetailTxt);
            img = rootView.FindViewById<ImageView>(Resource.Id.spacecraftDetailImg);

            //RECEIVE DATA
            string name = this.Arguments.GetString("NAME_KEY");
            int image = this.Arguments.GetInt("IMAGE_KEY");

            nameTxt.Text = name;
            img.SetImageResource(image);

            return rootView;
        }
    }
}