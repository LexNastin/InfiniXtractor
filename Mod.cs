using SRML;

namespace InfiniXtractor
{
    public class Mod : ModEntryPoint
    {
        public override void PreLoad()
        {
            HarmonyInstance.PatchAll();
        }

        public override void Load()
        {
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_DRILL_NOVICE).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_DRILL_ADVANCED).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_DRILL_MASTER).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_DRILL_TITAN).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_PUMP_NOVICE).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_PUMP_ADVANCED).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_PUMP_MASTER).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_PUMP_ABYSSAL).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_APIARY_NOVICE).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_APIARY_ADVANCED).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_APIARY_MASTER).prefab.GetComponent<Extractor>().infiniteCycles = true;
            SRSingleton<GameContext>.Instance.LookupDirector.GetGadgetDefinition(Gadget.Id.EXTRACTOR_APIARY_ROYAL).prefab.GetComponent<Extractor>().infiniteCycles = true;
        }
    }
}