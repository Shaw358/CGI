using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    /// <summary>
    /// Overall class to keep track of basic stats that belong on every planet
    /// </summary>
    protected int max_supply;
    private Inventory<Fleet> fleets = new Inventory<Fleet>();

    [SerializeField] protected string planet_name;
    private TravelLanes travel_lanes;

    private void Awake()
    {
        max_supply = 10;
        travel_lanes = GetComponentInChildren<TravelLanes>();
    }

    public void RemoveFleets(List<int> fleets_to_remove)
    {
        //fleets.RemoveItems(fleets_to_remove);
    }

    public TravelLanes GetLane()
    {
        TravelLanes[] lanes = GetComponentsInChildren<TravelLanes>();
        return lanes[0];
    }

    public string GetName()
    {
        return planet_name;
    }

    public int GetMaxSupply()
    {
        return max_supply;
    }

    public Inventory<Fleet> GetInventory()
    {
        return fleets;
    }

    public TravelLanes GetTravelLanes()
    {
        return travel_lanes;
    }
}