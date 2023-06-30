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
public class chucvu {
    int id;
    int machucvu;
    String tenchucvu;
    String ngaytao;
    int tienluong_id;
    int khenthuong;

    public chucvu() {
    }

    public chucvu(int id, int machucvu, String tenchucvu, String ngaytao, int tienluong_id, int khenthuong) {
        this.id = id;
        this.machucvu = machucvu;
        this.tenchucvu = tenchucvu;
        this.ngaytao = ngaytao;
        this.tienluong_id = tienluong_id;
        this.khenthuong = khenthuong;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getMachucvu() {
        return machucvu;
    }

    public void setMachucvu(int machucvu) {
        this.machucvu = machucvu;
    }

    public String getTenchucvu() {
        return tenchucvu;
    }

    public void setTenchucvu(String tenchucvu) {
        this.tenchucvu = tenchucvu;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }

    public int getTienluong_id() {
        return tienluong_id;
    }

    public void setTienluong_id(int tienluong_id) {
        this.tienluong_id = tienluong_id;
    }

    public int getKhenthuong() {
        return khenthuong;
    }

    public void setKhenthuong(int khenthuong) {
        this.khenthuong = khenthuong;
    }
    
    
}
