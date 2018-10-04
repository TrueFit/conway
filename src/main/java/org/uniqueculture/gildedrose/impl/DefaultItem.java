/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package org.uniqueculture.gildedrose.impl;

import org.uniqueculture.gildedrose.spi.Item;

/**
 *
 * @author me
 */
public class DefaultItem implements Item {
    
    String name;
    String categoryName;
    int sellInDay;
    int initialQuality;

    public DefaultItem(String name, String categoryName, int sellInDay, int initialQuality) {
        this.name = name;
        this.categoryName = categoryName;
        this.sellInDay = sellInDay;
        this.initialQuality = initialQuality;
    }

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public String getCategory() {
        return categoryName;
    }

    @Override
    public int getSellIn() {
        return this.sellInDay;
    }

    @Override
    public int getInitialQuality() {
        return this.initialQuality;
    }
}
