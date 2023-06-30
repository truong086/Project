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
public class phanhoi {
    int id;
    int nguoigui_id;
    int nguoinhan_id;
    String tieude;
    String chucvu;
    String noidung;
    String ngaygui;

    public phanhoi() {
    }

    public phanhoi(int id, int nguoigui_id, int nguoinhan_id, String tieude, String chucvu, String noidung, String ngaygui) {
        this.id = id;
        this.nguoigui_id = nguoigui_id;
        this.nguoinhan_id = nguoinhan_id;
        this.tieude = tieude;
        this.chucvu = chucvu;
        this.noidung = noidung;
        this.ngaygui = ngaygui;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getNguoigui_id() {
        return nguoigui_id;
    }

    public void setNguoigui_id(int nguoigui_id) {
        this.nguoigui_id = nguoigui_id;
    }

    public int getNguoinhan_id() {
        return nguoinhan_id;
    }

    public void setNguoinhan_id(int nguoinhan_id) {
        this.nguoinhan_id = nguoinhan_id;
    }

    public String getTieude() {
        return tieude;
    }

    public void setTieude(String tieude) {
        this.tieude = tieude;
    }

    public String getChucvu() {
        return chucvu;
    }

    public void setChucvu(String chucvu) {
        this.chucvu = chucvu;
    }

    public String getNoidung() {
        return noidung;
    }

    public void setNoidung(String noidung) {
        this.noidung = noidung;
    }

    public String getNgaygui() {
        return ngaygui;
    }

    public void setNgaygui(String ngaygui) {
        this.ngaygui = ngaygui;
    }
    
    
}
