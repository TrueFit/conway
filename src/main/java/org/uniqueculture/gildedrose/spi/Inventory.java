/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package org.uniqueculture.gildedrose.spi;

import java.util.List;

/**
 *
 * @author me
 */
public interface Inventory {
    
    List<InventoryItem> getItems();
    
    InventoryItem getInventoryItem(String name);
    
}
