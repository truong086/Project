/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.model;

/**
 *
 * @author ASUS
 */
public class cuochen {
    int id;
    String bacssi;
    String benhnhan;
    String noidung;
    String thoigian;

    public cuochen() {
    }

    public cuochen(int id, String bacssi, String benhnhan, String noidung, String thoigian) {
        this.id = id;
        this.bacssi = bacssi;
        this.benhnhan = benhnhan;
        this.noidung = noidung;
        this.thoigian = thoigian;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public String getBacssi() {
        return bacssi;
    }

    public void setBacssi(String bacssi) {
        this.bacssi = bacssi;
    }

    public String getBenhnhan() {
        return benhnhan;
    }

    public void setBenhnhan(String benhnhan) {
        this.benhnhan = benhnhan;
    }

    public String getNoidung() {
        return noidung;
    }

    public void setNoidung(String noidung) {
        this.noidung = noidung;
    }

    public String getThoigian() {
        return thoigian;
    }

    public void setThoigian(String thoigian) {
        this.thoigian = thoigian;
    }
    
    
    
}
