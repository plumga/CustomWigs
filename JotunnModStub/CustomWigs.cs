// JotunnModStub
// a Valheim mod skeleton using Jötunn
// 
// File:    JotunnModStub.cs
// Project: JotunnModStub

using BepInEx;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn.Configs;
using Jotunn.Managers;
using Jotunn.Entities;
using Jotunn.Utils;

namespace CustomWigs
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class CustomWigs : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.CustomWigs";
        public const string PluginName = "CustomWigs";
        public const string PluginVersion = "0.0.4";
        private AssetBundle assetwigs;


        private void Awake()
        {

            LoadAssets();

            LoadLoom();
            LoadLoomext1();
            LoadLoomext2();
            LoadLoomext3();
            //1989_qicc
            LoadWig1blk();
            LoadWig1blo();
            LoadWig1blue();
            LoadWig1brn();
            LoadWig1pink();
            LoadWig1red();
            //claire_kiara
            LoadWig2blo();
            LoadWig2blue();
            LoadWig2brn1();
            LoadWig2brn2();
            LoadWig2pink();
            LoadWig2red();
            //dreadsf
            LoadWig3blk();
            LoadWig3brn();
            //dreadsm
            LoadWig4blk();
            LoadWig4brn();
            //eris_sassy
            LoadWig5blk();
            LoadWig5blopink();
            LoadWig5blopurp();
            LoadWig5blue();
            LoadWig5brn();
            LoadWig5greenpurp();
            LoadWig5red();
            //grande
            LoadWig6blk();
            LoadWig6blo();
            LoadWig6blue();
            LoadWig6brn();
            LoadWig6red();
            //kendall_nightcrawler
            LoadWig7blk();
            LoadWig7blo();
            LoadWig7blue();
            LoadWig7brn();
            LoadWig7purp();
            LoadWig7red();
            //lila_feralpoodles
            LoadWig8blk();
            LoadWig8blo();
            LoadWig8brn1();
            LoadWig8brn2();
            LoadWig8red();
            //mohawk_kaisims
            LoadWig9blk();
            LoadWig9blo();
            LoadWig9brn1();
            LoadWig9brn2();
            LoadWig9red();
            //mohawk_redearcat
            LoadWig10blk();
            LoadWig10blo1();
            LoadWig10blo2();
            LoadWig10blue();
            LoadWig10brn1();
            LoadWig10brn2();
            LoadWig10green();
            LoadWig10pink();
            LoadWig10purple();
            LoadWig10red1();
            LoadWig10red2();
            LoadWig10teal();
            //nova_nightcrawler
            LoadWig11blk();
            LoadWig11blo();
            LoadWig11blue();
            LoadWig11brn();
            LoadWig11purp();
            LoadWig11red();
            //zahara_nords
            LoadWig12blk();
            LoadWig12blo();
            LoadWig12brn1();
            LoadWig12brn2();
            LoadWig12red();
            //LoadWigDverger1();
            LoadWigDverger2();
            LoadWigDverger3();
            LoadWigDverger4();
            LoadWigDverger5();

        }


        private void LoadAssets()
        {
            assetwigs = AssetUtils.LoadAssetBundleFromResources("wigsandloom", typeof(CustomWigs).Assembly);

        }




        private void LoadLoom()
        {
            var LoomAsset = assetwigs.LoadAsset<GameObject>("$custompiece_loom"); 
            var Loom = new CustomPiece(LoomAsset, fixReference: true,
                new PieceConfig
                {
                    PieceTable = "_HammerPieceTable",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 10, Recover = true},
                        new RequirementConfig {Item = "LinenThread", Amount = 10, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(Loom);
        }

        private void LoadLoomext1()
        {
            var extension1 = assetwigs.LoadAsset<GameObject>("$custompiece_loom_ext1");
            var ext1 = new CustomPiece(extension1, fixReference: true,
                new PieceConfig
                {
                    CraftingStation = "piece_workbench",
                    Description = "An extension for the loom.",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "$custompiece_loom",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext1);
        }

        private void LoadLoomext2()
        {
            var extension2 = assetwigs.LoadAsset<GameObject>("$custompiece_loom_ext2");
            var ext2 = new CustomPiece(extension2, fixReference: true,
                new PieceConfig
                {
                    CraftingStation = "piece_workbench",
                    Description = "An extension for the loom.",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "$custompiece_loom",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "Copper", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext2);
        }


        private void LoadLoomext3()
        {
            var extension3 = assetwigs.LoadAsset<GameObject>("$custompiece_loom_ext3");
            var ext3 = new CustomPiece(extension3, fixReference: true,
                new PieceConfig
                {
                    CraftingStation = "piece_workbench",
                    Description = "An extension for the loom.",
                    PieceTable = "Hammer",
                    Enabled = true,
                    ExtendStation = "$custompiece_loom",
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 1, Recover = true}
                    }

                });
            PieceManager.Instance.AddPiece(ext3);
        }



        private void LoadWigDverger2() //done
        {
            var WigDverger2Fab = assetwigs.LoadAsset<GameObject>("$dverger_eris_sassy_black");
            var WigDverger2 = new CustomItem(WigDverger2Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Black and Purple Dverger",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "$eris_sassy_black", Amount = 1},
                        new RequirementConfig { Item = "Crystal", Amount = 5},
                        new RequirementConfig { Item = "SurtlingCore", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "TrophyGoblinKing", Amount = 3, AmountPerLevel = 1}
                    }
                });
            ItemManager.Instance.AddItem(WigDverger2);

        }


        private void LoadWigDverger3() //done
        {
            var WigDverger3Fab = assetwigs.LoadAsset<GameObject>("$dverger_kendall_nightcrawler_purple");
            var WigDverger3 = new CustomItem(WigDverger3Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Purple Dverger",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "$kendall_nightcrawler_purple", Amount = 1},
                        new RequirementConfig { Item = "Crystal", Amount = 5},
                        new RequirementConfig { Item = "SurtlingCore", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "TrophyGoblinKing", Amount = 3, AmountPerLevel = 1}
                    }
                });
            ItemManager.Instance.AddItem(WigDverger3);

        }


        private void LoadWigDverger4() //done
        {
            var WigDverger4Fab = assetwigs.LoadAsset<GameObject>("$dverger_mohawkpony_redearcat_blonde2");
            var WigDverger4 = new CustomItem(WigDverger4Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Light Blonde Dverger",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "$mohawkpony_redearcat_blonde2", Amount = 5},
                        new RequirementConfig { Item = "Crystal", Amount = 5},
                        new RequirementConfig { Item = "SurtlingCore", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "TrophyGoblinKing", Amount = 3, AmountPerLevel = 1}
                    }
                });
            ItemManager.Instance.AddItem(WigDverger4);

        }


        private void LoadWigDverger5() //done
        {
            var WigDverger5Fab = assetwigs.LoadAsset<GameObject>("$dverger_nova_nightcrawler_purple");
            var WigDverger5 = new CustomItem(WigDverger5Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Purple Dverger",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 2,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "$nova_nightcrawler_purple", Amount = 1},
                        new RequirementConfig { Item = "Crystal", Amount = 5},
                        new RequirementConfig { Item = "SurtlingCore", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "TrophyGoblinKing", Amount = 3, AmountPerLevel = 1}
                    }
                });
            ItemManager.Instance.AddItem(WigDverger5);

        }



 

        private void LoadWig1blk() //done
        {
            var Wig1Fab = assetwigs.LoadAsset<GameObject>("$1989_qicc_black");
            var Wig1 = new CustomItem(Wig1Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bob Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig1);

        }

        private void LoadWig1blo() //done
        {
            var Wig01Fab = assetwigs.LoadAsset<GameObject>("$1989_qicc_blonde");
            var Wig01 = new CustomItem(Wig01Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bob Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig01);

        }

        private void LoadWig1blue() //done
        {
            var Wig001Fab = assetwigs.LoadAsset<GameObject>("$1989_qicc_blue");
            var Wig001 = new CustomItem(Wig001Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bob Blue",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig001);

        }

        private void LoadWig1brn() //done
        {
            var Wig0001Fab = assetwigs.LoadAsset<GameObject>("$1989_qicc_brown");
            var Wig0001 = new CustomItem(Wig0001Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bob Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0001);

        }

        private void LoadWig1pink() //done
        {
            var Wig00001Fab = assetwigs.LoadAsset<GameObject>("$1989_qicc_pink");
            var Wig00001 = new CustomItem(Wig00001Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bob Pink",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Raspberry", Amount = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig00001);

        }

        private void LoadWig1red() //done
        {
            var Wig00001Fab = assetwigs.LoadAsset<GameObject>("$1989_qicc_red");
            var Wig00001 = new CustomItem(Wig00001Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bob Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00001);

        }


        private void LoadWig2blo() //done
        {
            var Wig2Fab = assetwigs.LoadAsset<GameObject>("$claire_kiara_blonde");
            var Wig2 = new CustomItem(Wig2Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Side Braid Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig2);

        }

        private void LoadWig2blue() //done
        {
            var Wig02Fab = assetwigs.LoadAsset<GameObject>("$claire_kiara_blue");
            var Wig02 = new CustomItem(Wig02Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Side Braid Blue",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig02);

        }

        private void LoadWig2brn1() //done
        {
            var Wig002Fab = assetwigs.LoadAsset<GameObject>("$claire_kiara_brown1");
            var Wig002 = new CustomItem(Wig002Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Side Braid Dark Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig002);

        }

        private void LoadWig2brn2() //done
        {
            var Wig0002Fab = assetwigs.LoadAsset<GameObject>("$claire_kiara_brown2");
            var Wig0002 = new CustomItem(Wig0002Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Side Braid Light Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1},
                    }
                });
            ItemManager.Instance.AddItem(Wig0002);

        }

        private void LoadWig2pink() //done
        {
            var Wig00002Fab = assetwigs.LoadAsset<GameObject>("$claire_kiara_pink");
            var Wig00002 = new CustomItem(Wig00002Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Side Braid Pink",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Raspberry", Amount = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1},
                    }
                });
            ItemManager.Instance.AddItem(Wig00002);

        }

        private void LoadWig2red() //done
        {
            var Wig000002Fab = assetwigs.LoadAsset<GameObject>("$claire_kiara_red");
            var Wig000002 = new CustomItem(Wig000002Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Side Braid Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig000002);

        }

        private void LoadWig3blk() //done
        {
            var Wig3Fab = assetwigs.LoadAsset<GameObject>("$dreadsf_necrodog_black");
            var Wig3 = new CustomItem(Wig3Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Dreads F Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig3);

        }

        private void LoadWig3brn() //done
        {
            var Wig03Fab = assetwigs.LoadAsset<GameObject>("$dreadsf_necrodog_brown");
            var Wig03 = new CustomItem(Wig03Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Dreads F Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig03);

        }

        private void LoadWig4blk() //done
        {
            var Wig4Fab = assetwigs.LoadAsset<GameObject>("$dreadsm_necrodog_black");
            var Wig4 = new CustomItem(Wig4Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Dreads M Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig4);

        }

        private void LoadWig4brn() //done
        {
            var Wig04Fab = assetwigs.LoadAsset<GameObject>("$dreadsm_necrodog_brown");
            var Wig04 = new CustomItem(Wig04Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Dreads M Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig04);

        }


        private void LoadWig5blk() //done
        {
            var Wig5Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_black");
            var Wig5 = new CustomItem(Wig5Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Black and Purple",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 1},
                        new RequirementConfig { Item = "Blueberries", Amount = 1},
                        new RequirementConfig { Item = "Raspberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig5);

        }

        private void LoadWig5blopink() //done
        {
            var Wig05Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_blondepink");
            var Wig05 = new CustomItem(Wig05Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Blonde and Pink",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1},
                        new RequirementConfig { Item = "Raspberry", Amount = 1},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig05);

        }

        private void LoadWig5blopurp() //done
        {
            var Wig005Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_blondepurp");
            var Wig005 = new CustomItem(Wig005Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Blonde and Purple",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1},
                        new RequirementConfig { Item = "Blueberries", Amount = 1},
                        new RequirementConfig { Item = "Raspberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig005);

        }

        private void LoadWig5blue() //done
        {
            var Wig0005Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_blue");
            var Wig0005 = new CustomItem(Wig0005Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Blue Fade",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig0005);

        }

        private void LoadWig5brn() //done
        {
            var Wig00005Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_brown");
            var Wig00005 = new CustomItem(Wig00005Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Brown and Green",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 2},
                        new RequirementConfig { Item = "Guck", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig00005);

        }

        private void LoadWig5greenpurp() //done
        {
            var Wig000005Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_greenpurp");
            var Wig000005 = new CustomItem(Wig000005Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Green and Purple",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 1},
                        new RequirementConfig { Item = "Raspberry", Amount = 1},
                        new RequirementConfig { Item = "Guck", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig000005);

        }
    
        private void LoadWig5red() //done
        {
            var Wig0000005Fab = assetwigs.LoadAsset<GameObject>("$eris_sassy_red");
            var Wig0000005 = new CustomItem(Wig0000005Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bangs Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0000005);

        }


        private void LoadWig6blk() //done
        {
            var Wig6Fab = assetwigs.LoadAsset<GameObject>("$grande_littledica_black");
            var Wig6 = new CustomItem(Wig6Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Half Up Pony Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig6);

        }

        private void LoadWig6blo() //done
        {
            var Wig06Fab = assetwigs.LoadAsset<GameObject>("$grande_littledica_blonde");
            var Wig06 = new CustomItem(Wig06Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Half Up Pony Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig06);

        }

        private void LoadWig6blue() //done
        {
            var Wig006Fab = assetwigs.LoadAsset<GameObject>("$grande_littledica_blue");
            var Wig006 = new CustomItem(Wig006Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Half Up Pony Blue",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig006);

        }

        private void LoadWig6brn() //done
        {
            var Wig0006Fab = assetwigs.LoadAsset<GameObject>("$grande_littledica_brown");
            var Wig0006 = new CustomItem(Wig0006Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Half Up Pony Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0006);

        }

        private void LoadWig6red() //done
        {
            var Wig00006Fab = assetwigs.LoadAsset<GameObject>("$grande_littledica_red");
            var Wig00006 = new CustomItem(Wig00006Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Half Up Pony Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00006);

        }

        private void LoadWig7blk() //done
        {
            var Wig7Fab = assetwigs.LoadAsset<GameObject>("$kendall_nightcrawler_black");
            var Wig7 = new CustomItem(Wig7Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig7);

        }

        private void LoadWig7blo() //done
        {
            var Wig07Fab = assetwigs.LoadAsset<GameObject>("$kendall_nightcrawler_blonde");
            var Wig07 = new CustomItem(Wig07Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig07);

        }

        private void LoadWig7blue() //done
        {
            var Wig007Fab = assetwigs.LoadAsset<GameObject>("$kendall_nightcrawler_blue");
            var Wig007 = new CustomItem(Wig007Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Blue",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig007);

        }

        private void LoadWig7brn() //done
        {
            var Wig0007Fab = assetwigs.LoadAsset<GameObject>("$kendall_nightcrawler_brown");
            var Wig0007 = new CustomItem(Wig0007Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0007);

        }

        private void LoadWig7purp() //done
        {
            var Wig00007Fab = assetwigs.LoadAsset<GameObject>("$kendall_nightcrawler_purple");
            var Wig00007 = new CustomItem(Wig00007Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Purple",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 1},
                        new RequirementConfig { Item = "Raspberry", Amount = 1},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig00007);

        }

        private void LoadWig7red() //done
        {
            var Wig000007Fab = assetwigs.LoadAsset<GameObject>("$kendall_nightcrawler_red");
            var Wig000007 = new CustomItem(Wig000007Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Bun Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig000007);

        }

        private void LoadWig8blk() //done
        {
            var Wig8Fab = assetwigs.LoadAsset<GameObject>("$lila_feralpoodles_black");
            var Wig8 = new CustomItem(Wig8Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns with Curls Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig8);

        }

        private void LoadWig8blo() //done
        {
            var Wig08Fab = assetwigs.LoadAsset<GameObject>("$lila_feralpoodles_blonde");
            var Wig08 = new CustomItem(Wig08Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns with Curls Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig08);

        }

        private void LoadWig8brn1() //done
        {
            var Wig008Fab = assetwigs.LoadAsset<GameObject>("$lila_feralpoodles_brown1");
            var Wig008 = new CustomItem(Wig008Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns with Curls Dark Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig008);

        }

        private void LoadWig8brn2() //done
        {
            var Wig0008Fab = assetwigs.LoadAsset<GameObject>("$lila_feralpoodles_brown2");
            var Wig0008 = new CustomItem(Wig0008Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns with Curls Light Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig0008);

        }

        private void LoadWig8red() //done
        {
            var Wig00008Fab = assetwigs.LoadAsset<GameObject>("$lila_feralpoodles_red");
            var Wig00008 = new CustomItem(Wig00008Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns with Curls Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00008);

        }



        private void LoadWig9blk() //done
        {
            var Wig9Fab = assetwigs.LoadAsset<GameObject>("$mohawk_kaisims_blackred");
            var Wig9 = new CustomItem(Wig9Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Curly Fade Black and Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig9);

        }

        private void LoadWig9blo() //done
        {
            var Wig09Fab = assetwigs.LoadAsset<GameObject>("$mohawk_kaisims_blonde");
            var Wig09 = new CustomItem(Wig09Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Curly Fade Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig09);

        }

        private void LoadWig9brn1() //done
        {
            var Wig009Fab = assetwigs.LoadAsset<GameObject>("$mohawk_kaisims_brown1");
            var Wig009 = new CustomItem(Wig009Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Curly Fade Dark Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig009);

        }

        private void LoadWig9brn2() //done
        {
            var Wig0009Fab = assetwigs.LoadAsset<GameObject>("$mohawk_kaisims_brown2");
            var Wig0009 = new CustomItem(Wig0009Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Curly Fade Light Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig0009);

        }

        private void LoadWig9red() //done
        {
            var Wig00009Fab = assetwigs.LoadAsset<GameObject>("$mohawk_kaisims_red");
            var Wig00009 = new CustomItem(Wig00009Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Curly Fade Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00009);

        }



        private void LoadWig10blk()  //done
        {
            var Wig10Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_black");
            var Wig10 = new CustomItem(Wig10Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig10);

        }


        private void LoadWig10blo1()  //done
        {
            var Wig010Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_blonde1");
            var Wig010 = new CustomItem(Wig010Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig010);

        }

        private void LoadWig10blo2() //done
        {
            var Wig0010Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_blonde2");
            var Wig0010 = new CustomItem(Wig0010Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Light Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0010);

        }

        private void LoadWig10blue() //done
        {
            var Wig00010Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_blue");
            var Wig00010 = new CustomItem(Wig00010Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Blue",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00010);

        }


        private void LoadWig10brn1() //done
        {
            var Wig000010Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_brown1");
            var Wig000010 = new CustomItem(Wig000010Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Dark Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig000010);

        }

        private void LoadWig10brn2() //done
        {
            var Wig0000010Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_brown2");
            var Wig0000010 = new CustomItem(Wig0000010Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Light Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig0000010);

        }

        private void LoadWig10green() //done
        {
            var Wig00000010Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_green");
            var Wig00000010 = new CustomItem(Wig00000010Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Green",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Guck", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00000010);

        }

        private void LoadWig10pink() //done
        {
            var Wigx10Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_pink");
            var Wigx10 = new CustomItem(Wigx10Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Pink",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Raspberry", Amount = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wigx10);

        }

        private void LoadWig10purple() //done
        {
            var Wigxx10Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_purple");
            var Wigxx10 = new CustomItem(Wigxx10Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Purple",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 2},
                        new RequirementConfig { Item = "Raspberry", Amount = 2}
                    }
                });
            ItemManager.Instance.AddItem(Wigxx10);

        }

        private void LoadWig10red1()//done
        {
            var Wigxxx10Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_red1");
            var Wigxxx10 = new CustomItem(Wigxxx10Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Bright Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 2},
                        new RequirementConfig { Item = "Raspberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wigxxx10);

        }

        private void LoadWig10red2() //done
        {
            var Wigxxxx10Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_red2");
            var Wigxxxx10 = new CustomItem(Wigxxxx10Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Natural Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wigxxxx10);

        }

        private void LoadWig10teal() //done
        {
            var Wigxxxxx10Fab = assetwigs.LoadAsset<GameObject>("$mohawkpony_redearcat_teal");
            var Wigxxxxx10 = new CustomItem(Wigxxxxx10Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Spiky Mohawk Teal",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 2},
                        new RequirementConfig { Item = "Guck", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wigxxxxx10);

        }


        private void LoadWig11blk() //done
        {
            var Wig11Fab = assetwigs.LoadAsset<GameObject>("$nova_nightcrawler_black");
            var Wig11 = new CustomItem(Wig11Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig11);

        }

        private void LoadWig11blo() //done
        {
            var Wig011Fab = assetwigs.LoadAsset<GameObject>("$nova_nightcrawler_blonde");
            var Wig011 = new CustomItem(Wig011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig011);

        }

        private void LoadWig11blue() //done
        {
            var Wig0011Fab = assetwigs.LoadAsset<GameObject>("$nova_nightcrawler_blue");
            var Wig0011 = new CustomItem(Wig0011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Blue",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 2},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig0011);

        }

        private void LoadWig11brn() //done
        {
            var Wig00011Fab = assetwigs.LoadAsset<GameObject>("$nova_nightcrawler_brown");
            var Wig00011 = new CustomItem(Wig00011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig00011);

        }

        private void LoadWig11purp() //done
        {
            var Wig000011Fab = assetwigs.LoadAsset<GameObject>("$nova_nightcrawler_purple");
            var Wig000011 = new CustomItem(Wig000011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Purple",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Blueberries", Amount = 1},
                        new RequirementConfig { Item = "Raspberry", Amount = 1},
                        new RequirementConfig { Item = "Cloudberry", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig000011);

        }

        private void LoadWig11red() //done
        {
            var Wig0000011Fab = assetwigs.LoadAsset<GameObject>("$nova_nightcrawler_red");
            var Wig0000011 = new CustomItem(Wig0000011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "High Pony Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0000011);

        }


        private void LoadWig12blk() //done
        {
            var Wig11Fab = assetwigs.LoadAsset<GameObject>("$zahara_nords_black");
            var Wig11 = new CustomItem(Wig11Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns Black",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Coal", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig11);

        }

        private void LoadWig12blo() //done
        {
            var Wig011Fab = assetwigs.LoadAsset<GameObject>("$zahara_nords_blonde");
            var Wig011 = new CustomItem(Wig011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns Blonde",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig011);

        }

        private void LoadWig12brn1() //done
        {
            var Wig0011Fab = assetwigs.LoadAsset<GameObject>("$zahara_nords_brown1");
            var Wig0011 = new CustomItem(Wig0011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns Dark Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig0011);

        }

        private void LoadWig12brn2() //done
        {
            var Wig00011Fab = assetwigs.LoadAsset<GameObject>("$zahara_nords_brown2");
            var Wig00011 = new CustomItem(Wig00011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns Light Brown",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "BeechSeeds", Amount = 2},
                        new RequirementConfig { Item = "MushroomYellow", Amount = 1}
                    }
                });
            ItemManager.Instance.AddItem(Wig00011);

        }

        private void LoadWig12red() //done
        {
            var Wig000011Fab = assetwigs.LoadAsset<GameObject>("$zahara_nords_red");
            var Wig000011 = new CustomItem(Wig000011Fab, fixReference: true,
                new ItemConfig
                {
                    Amount = 1,
                    Name = "Buns Red",
                    CraftingStation = "$custompiece_loom",
                    RepairStation = "$custompiece_loom",
                    MinStationLevel = 1,
                    Requirements = new[]
                    {
                        new RequirementConfig { Item = "LinenThread", Amount = 5, AmountPerLevel = 2},
                        new RequirementConfig { Item = "Bloodbag", Amount = 3}
                    }
                });
            ItemManager.Instance.AddItem(Wig000011);

        }


        //notes

        //  private void LoadShovel()
        //  {
        //      var shovelfab = assetwigs.LoadAsset<GameObject>("WigTest2");
        //      var shovel = new CustomItem(shovelfab, fixReference: true,
        //          new ItemConfig
        //          {
        //             Amount = 1,
        //             Name = "Wig1",
        //             CraftingStation = "$custompiece_loom",
        //              RepairStation = "$custompiece_loom",
        //             MinStationLevel = 1,
        //              Requirements = new[]
        //             {
        //                  new RequirementConfig { Item = "Wood", Amount = 1}
        //              }
        //          });
        //      ItemManager.Instance.AddItem(shovel);

        //  }


        /// notes to self 
        //  private void LoadWigTest() //function name - change each time 
        // {
        //     var AssetWigTest = plants.LoadAsset<GameObject>("WigTest"); //prefab name in uniy project 
        // need to change AssetWigTest and WigTestItem every time you copy this 
        //     var WigTestItem = new CustomItem(AssetWigTest,
        //         new ItemConfig
        //         {
        //             Amount = 1,
        //             Requirements = new[]
        //             {
        //                 new RequirementConfig {Item = "Wood", Amount = 2}
        //             }
        //         });
        //     ItemManager.Instance.AddPiece(WigTestItem);
        //   }


        // to here 

    }
}