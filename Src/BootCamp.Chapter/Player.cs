﻿using System;
using System.Runtime.InteropServices.WindowsRuntime;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    /// <summary>
    /// Task: simulate a player who has an inventory.
    /// Player can add or remove items from inventory.
    ///
    /// Extra task: player has equipement and maximum weight he/she can carry.
    /// Player should not be able to take items if already at maximum weight.
    /// Player should expose TotalAttack, TotalDefense stats.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Everyone can carry this much weight at least.
        /// </summary>
        private const int baseCarryWeight = 30;

        private string _name;

        public string GetName()
        {
            return _name;
        }
        
        private int _hp;

        public int GetHp()
        {
            return _hp;

        }

        /// <summary>
        /// Each point of strength allows extra 10 kg to carry.
        /// </summary>
        private int _strenght;
        public int GetStrength()
        {
            return _strenght;

        }
        
        private int _carryWeight;
        public int GetCarryWeight()
        {
            return _carryWeight;

        }
        /// <summary>
        /// Player items. There can be multiple of items with same name.
        /// </summary>
        private Inventory _inventory;
        /// <summary>
        /// Needed only for the extra task.
        /// </summary>
        private Equipment _equipment;

        public Player() //Leave it for tests.
        {
            _inventory = new Inventory();
            _equipment = new Equipment();
            _carryWeight = baseCarryWeight;
        }

        public Player(string name, int hp, int strenght)
        {
            if (name == null || hp == 0 || strenght == 0) throw new Exception("Name, int and strength must have a value!");
            _name = name;
            _hp = hp;
            _strenght = strenght;
            CalculateCarryWeight(strenght);
            _inventory = new Inventory();
            _equipment = new Equipment();

        }

        /// <summary>
        /// Gets all items from player's inventory
        /// </summary>
        public Item[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to player's inventory
        /// </summary>
        public void AddItem(Item item)
        {
            _inventory.AddItem(item);
        }

        public void Remove(Item item)
        {
            _inventory.RemoveItem(item);
        }

        /// <summary>
        /// Gets items with matching name.
        /// </summary>
        /// <param name="name"></param>
        public Item[] GetItems(string name)
        {
            return _inventory.GetItems(name);
        }

        #region Extra challenge: Equipment
        // Player has equipment.
        // Various slots of equipment can be equiped and unequiped.
        // When a slot is equiped, it contributes to total defense
        // and total attack.
        // Implement equiping logic and total defense/attack calculation.
        public void Equip(Headpiece head)
        {

        }

        public void Equip(Chestpiece head)
        {

        }

        public void Equip(Shoulderpiece head, bool isLeft)
        {

        }

        public void Equip(Legspiece head)
        {

        }

        public void Equip(Armpiece head, bool isLeft)
        {

        }

        public void Equip(Gloves head)
        {

        }
        #endregion
        private void CalculateCarryWeight(int strength)
        {
            _carryWeight = baseCarryWeight + (strength * 10);
        }
    }
}
