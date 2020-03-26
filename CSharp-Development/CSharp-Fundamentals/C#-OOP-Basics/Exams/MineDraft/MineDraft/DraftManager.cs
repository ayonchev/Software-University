using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private WorkMode workMode;
    private double totalEnergyStored;
    private double totalMinedOre;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.workMode = WorkMode.Full;
        this.totalEnergyStored = 0;
        this.totalMinedOre = 0;
    }
    public string RegisterHarvester(List<string> arguments)
    {
        try
        {
            Harvester newHarvester = HarvesterFactory.CreateHarvester(arguments);
            harvesters.Add(newHarvester);
            return $"Successfully registered {newHarvester.Type} Harvester - {newHarvester.Id}";
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }
    public string RegisterProvider(List<string> arguments)
    {
        try
        {
            Provider newProvider = ProviderFactory.CreateProvider(arguments);
            providers.Add(newProvider);
            return $"Successfully registered {newProvider.Type} Provider - {newProvider.Id}";
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }
    public string Day()
    {
        double summedEnergyOutput = providers.Sum(p => p.EnergyOutput);
        this.totalEnergyStored += summedEnergyOutput;

        double summedOreOutput = 0;

        double reqiredEnergy = harvesters.Sum(h => h.EnergyRequirement);

        double oreProducementPercent = 0;
        switch (workMode)
        {
            case WorkMode.Full:
                oreProducementPercent = 1;
                break;
            case WorkMode.Half:
                reqiredEnergy *= 0.6;
                oreProducementPercent = 0.5;
                break;
            case WorkMode.Energy:
                reqiredEnergy = 0;
                break;
        }

        if (totalEnergyStored >= reqiredEnergy)
        {
            summedOreOutput += (harvesters.Sum(h => h.OreOutput) * oreProducementPercent);
            totalEnergyStored -= reqiredEnergy;
        }
        totalMinedOre += summedOreOutput;

        return "A day has passed." + Environment.NewLine +
               $"Energy Provided: {summedEnergyOutput}" + Environment.NewLine +
               $"Plumbus Ore Mined: {summedOreOutput}";
    }
    public string Mode(List<string> arguments)
    {
        string newWorkMode = arguments[0];
        WorkMode.TryParse(newWorkMode, out this.workMode);

        return $"Successfully changed working mode to {this.workMode} Mode";
    }
    public string Check(List<string> arguments)
    {
        string id = arguments[0];

        if (harvesters.Any(h => h.Id == id))
        {
            return harvesters.FirstOrDefault(h => h.Id == id).ToString();
        }
        else if (providers.Any(p => p.Id == id))
        {
            return providers.FirstOrDefault(p => p.Id == id).ToString();
        }

        return $"No element found with id - {id}";
    }
    public string ShutDown()
    {
        return $"System Shutdown" + Environment.NewLine +
               $"Total Energy Stored: {totalEnergyStored}" + Environment.NewLine +
               $"Total Mined Plumbus Ore: {totalMinedOre}";
    }
}

