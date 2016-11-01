using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Util;
using MDListView_DialogFrag.mCode.mData;
using Object = Java.Lang.Object;

namespace MDListView_DialogFrag.mCode.mListView
{
    class CustomAdapter : BaseAdapter
    {
        private Context c;
        private JavaList<SpaceCraft> spaceCrafts;
        private LayoutInflater inflater;

        public CustomAdapter(Context c, JavaList<SpaceCraft> spaceCrafts)
        {
            this.c = c;
            this.spaceCrafts = spaceCrafts;

            //INITIALIZE INFLATER
            inflater = (LayoutInflater) c.GetSystemService(Context.LayoutInflaterService);
        }

        public override Object GetItem(int position)
        {
           return spaceCrafts.Get(position);
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
            {
                convertView = inflater.Inflate(Resource.Layout.Model, parent, false);
            }

            TextView nametxt = convertView.FindViewById<TextView>(Resource.Id.nameTxt);
            ImageView img = convertView.FindViewById<ImageView>(Resource.Id.spacecraftImg);

            string name = spaceCrafts[position].Name;
            int image = spaceCrafts[position].Image;

            //BINDING DATA
            nametxt.Text = name;
            img.SetImageResource(image);

            return convertView;
        }

        public override int Count
        {
            get { return spaceCrafts.Size(); }
        }
    }
}