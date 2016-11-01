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

namespace MDListView_DialogFrag.mCode.mData
{
    class SpaceCraftsCollection
    {
        public static JavaList<SpaceCraft> GetSpaceCrafts()
        {
            JavaList<SpaceCraft> spaceCrafts=new JavaList<SpaceCraft>();
            SpaceCraft spaceCraft = null;

            spaceCraft=new SpaceCraft();
            spaceCraft.Name = "Spitzer";
            spaceCraft.Image = Resource.Drawable.spitzer;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Enterprise";
            spaceCraft.Image = Resource.Drawable.enterprise;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Hubble";
            spaceCraft.Image = Resource.Drawable.hubble;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Kepler";
            spaceCraft.Image = Resource.Drawable.kepler;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Challenger";
            spaceCraft.Image = Resource.Drawable.challenger;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Voyager";
            spaceCraft.Image = Resource.Drawable.voyager;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Columbia";
            spaceCraft.Image = Resource.Drawable.columbia;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Apollo";
            spaceCraft.Image = Resource.Drawable.apollo;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Opportunity";
            spaceCraft.Image = Resource.Drawable.opportunity;
            spaceCrafts.Add(spaceCraft);

            spaceCraft = new SpaceCraft();
            spaceCraft.Name = "Rosetter";
            spaceCraft.Image = Resource.Drawable.rosetta;
            spaceCrafts.Add(spaceCraft);


            return spaceCrafts;

        }
    }
}