using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OotReference
{
    public sealed class Category
    {
        public int numConnections;
        public Location location;
        public Location[] connections;
        public Trick[] trick;
        public Item[] item;
        public Song[] song;
        public static Category[] Region = new Category[]
        {
            Category.KokiriForest(),
            Category.LostWoods(),
            Category.HyruleField(),
            Category.HyruleCastle(),
            Category.HyruleTown(),
            Category.LonLonRanch(),
            Category.DekuTree()
        };
        public static Trick[] GlobalTricks = new Trick[]
        {
            Trick.ActionSwap,
            Trick.BackWalking,
            Trick.BombHover,
            Trick.BottleAdventure,
            Trick.BottleDuping,
            Trick.EquipSwap,
            Trick.ExtendedSuperSlide,
            Trick.ForwardESS,
            Trick.Gainer,
            Trick.HyperESS,
            Trick.InfiniteSwordGlitch,
            Trick.LedgeClip,
            Trick.MegaFlip,
            Trick.MegaSideHop,
            Trick.NoBoots,
            Trick.OcarinaItems,
            Trick.PowerCrouchStab,
            Trick.RecoilFlip,
            Trick.ReverseBottleAdventure,
            Trick.SuperSlide,
            Trick.WeirdShot,
            Trick.ZSlide
        };
        public static Item[] GlobalItems = new Item[]
        {
            Item.GreenRupee,
            Item.BlueRupee,
            Item.RedRupee,
            Item.Rupees,
            Item.GreenTunic,
            Item.NormalBoots
        };
        static Category KokiriForest()
        {
            return new Category() 
            { 
                location = Location.KokiriForest,
                item = new Item[]
                {
                    Item.KokiriSword,
                    Item.DekuNuts,
                    Item.DekuStick,
                    Item.DekuShield,
                    Item.Rupees,
                    Item.GoldSkultula
                },
                song = default,
                connections = new Location[]
                {
                    Location.DekuTree,
                    Location.LostWoods,
                    Location.Grotto
                },
                trick = new Trick[]
                {
                    Trick.ExitForestEarly,
                    Trick.MidoSkip
                },
                numConnections = 3
            };
        }
        static Category LostWoods()
        {
            return new Category()
            {
                location = Location.LostWoods,
                item = new Item[]
                {
                    Item.DekuNuts,
                    Item.DekuStick,
                    Item.Faerie,
                    Item.Bugs,
                    Item.Water,
                    Item.TradeQuestItem,
                    Item.HeartPiece,
                    Item.GoldSkultula
                },
                connections = new Location[] 
                {
                    Location.SacredForestMedow,
                    Location.GoronCity,
                    Location.ZorasRiver,
                    Location.KokiriForest,
                    Location.HyruleField
                },
                song = default,
                trick = new Trick[]
                {
                    Trick.OcarinaDive,
                    Trick.NaviDive
                },
                numConnections = 5
            };
        }
        static Category HyruleField()
        {
            return new Category()
            {
                location = Location.HyruleField,
                connections = new Location[]
                {
                    Location.Grotto,
                    Location.HyruleTown,
                    Location.KakarikoVillage,
                    Location.GerudoValley,
                    Location.KokiriForest,
                    Location.LakeHylia,
                    Location.LonLonRanch,
                    Location.ZorasRiver
                },
                item = new Item[]
                {
                    Item.DekuNuts,
                    Item.Faerie,
                    Item.DekuStick,
                    Item.OcarinaOfTime
                },
                song = default,
                trick = default,
                numConnections = 8
            };
        }
        static Category HyruleCastle()
        {
            return new Category()
            {
                location = Location.HyruleCastle,
                connections = new Location[]
                {
                    Location.HyruleTown,
                    Location.FaerieFountain,
                    Location.Grotto
                },
                item = new Item[]
                {
                    Item.ZeldasLetter,
                    Item.KukoEgg
                },
                song = new Song[]
                {
                    Song.ZeldasLulaby
                },
                trick = default,
                numConnections = 3
            };
        }
        static Category HyruleTown()
        {
            return new Category()
            {
                location = Location.HyruleTown,
                connections = new Location[]
                {
                    Location.HyruleField,
                    Location.HyruleCastle,
                    Location.TempleOfTime
                },
                item = new Item[]
                {
                    Item.HeartPiece,
                    Item.BombBag,
                    Item.SlingshotBagUpgrade,
                    Item.KeatonMask,
                    Item.HylianShield,
                    Item.DekuStick,
                    Item.SlingshotSeeds,
                    Item.DekuNuts
                },
                song = default,
                trick = default,
                numConnections = 3
            };
        }
        static Category LonLonRanch()
        {
            return new Category()
            {
                location = Location.LonLonRanch,
                connections = new Location[]
                {
                    Location.HyruleField
                },
                item = new Item[]
                {
                    Item.GoldSkultula,
                    Item.HeartPiece,
                    Item.Bottle,
                    Item.Milk
                },
                song = new Song[] 
                {
                    Song.EponasSong 
                },
                trick = default,
                numConnections = 1
            };
        }
        static Category DekuTree()
        {
            return new Category()
            {
                location = Location.DekuTree,
                connections = new Location[]
                {
                    Location.KokiriForest
                },
                item = new Item[]
                {
                    Item.Slingshot,
                    Item.HeartPiece,
                    Item.HeartContainer,
                    Item.GoldSkultula,
                    Item.DekuNuts,
                    Item.DekuStick
                },
                song = default,
                trick = new Trick[]
                { 
                    Trick.WrongWarp // GhanonDoor
                },
                numConnections = 1
            };
        }
        static Category KakarikoVillage()
        {
            return new Category()
            {
                location = Location.KakarikoVillage,
                connections = new Location[]
                {
                    Location.DeathMountainTrail,
                    Location.Graveyard,
                    Location.KakarikoArchery,
                    Location.BottomOfTheWell,
                    Location.HouseOfSkulltulas,
                    Location.Windmill
                },
                item = new Item[]
                {
                    Item.QuiverUpgrade,
                    Item.HylianShield,
                    Item.DekuStick,
                    Item.DekuNuts,
                    Item.Faerie,
                    Item.Bugs,
                    Item.WalletUpgrade,
                    Item.StoneOfAgony,
                    Item.GoldSkultula,
                    Item.HeartPiece
                },
                song = new Song[]
                {
                    Song.SongOfTime
                },
                trick = new Trick[]
                {

                }
            };
        }
    }
}
