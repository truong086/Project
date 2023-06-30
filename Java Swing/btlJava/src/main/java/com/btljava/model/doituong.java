/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.model;

import java.time.LocalDate;

/**
 *
 * @author ASUS
 */
public class doituong {
    int id;
    int madoituong;
    String tendoituong;
    String ngaythem;

    public doituong() {
    }

    public doituong(int id, int madoituong, String tendoituong, String ngaythem) {
        this.id = id;
        this.madoituong = madoituong;
        this.tendoituong = tendoituong;
        this.ngaythem = ngaythem;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getMadoituong() {
        return madoituong;
    }

    public void setMadoituong(int madoituong) {
        this.madoituong = madoituong;
    }

    public String getTendoituong() {
        return tendoituong;
    }

    public void setTendoituong(String tendoituong) {
        this.tendoituong = tendoituong;
    }

    public String getNgaythem() {
        return ngaythem;
    }

    public void setNgaythem(String ngaythem) {
        this.ngaythem = ngaythem;
    }
}
