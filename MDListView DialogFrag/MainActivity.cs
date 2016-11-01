using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using MDListView_DialogFrag.mCode.mData;
using MDListView_DialogFrag.mCode.mFragment;
using MDListView_DialogFrag.mCode.mListView;


namespace MDListView_DialogFrag
{
    [Activity(Label = "MD ListView DialogFrag", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private ListView lv;
        private CustomAdapter adapter;
        private JavaList<SpaceCraft> spaceCrafts=null; 

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            lv = FindViewById<ListView>(Resource.Id.lv);

            spaceCrafts = SpaceCraftsCollection.GetSpaceCrafts();
            adapter=new CustomAdapter(this,spaceCrafts);
            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;

        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            SpaceCraft s = spaceCrafts[e.Position];
            OpenDetailFragment(s.Name,s.Image);
        }

        //OPEN DETAIL FRAGMENT
        private void OpenDetailFragment(String name,int image)
        {
            //BUNDLE DATA
            Bundle b=new Bundle();
            b.PutString("NAME_KEY",name);
            b.PutInt("IMAGE_KEY",image);

            //SEND
            SpacecraftFragment spacecraftFragment=new SpacecraftFragment();
            spacecraftFragment.Arguments = b;

            //SHOW
            spacecraftFragment.Show(this.FragmentManager, "mTag");

        }

    }
}

