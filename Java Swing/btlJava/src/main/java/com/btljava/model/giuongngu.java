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
public class giuongngu {
    int id;
    int giuong_id;
    int benhnhan_id;
    String thoigiannam;
    String thoigianra;

    public giuongngu() {
    }

    public giuongngu(int id, int giuong_id, int benhnhan_id, String thoigiannam, String thoigianra) {
        this.id = id;
        this.giuong_id = giuong_id;
        this.benhnhan_id = benhnhan_id;
        this.thoigiannam = thoigiannam;
        this.thoigianra = thoigianra;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getGiuong_id() {
        return giuong_id;
    }

    public void setGiuong_id(int giuong_id) {
        this.giuong_id = giuong_id;
    }

    public int getBenhnhan_id() {
        return benhnhan_id;
    }

    public void setBenhnhan_id(int benhnhan_id) {
        this.benhnhan_id = benhnhan_id;
    }

    public String getThoigiannam() {
        return thoigiannam;
    }

    public void setThoigiannam(String thoigiannam) {
        this.thoigiannam = thoigiannam;
    }

    public String getThoigianra() {
        return thoigianra;
    }

    public void setThoigianra(String thoigianra) {
        this.thoigianra = thoigianra;
    }
    
    
    
}
