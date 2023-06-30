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
public class tienluong {
    int id;
    int matienluong;
    int tienluong;
    int ngaycong;
    String ngaytao;

    public tienluong() {
    }

    public tienluong(int id, int matienluong, int tienluong, int ngaycong, String ngaytao) {
        this.id = id;
        this.matienluong = matienluong;
        this.tienluong = tienluong;
        this.ngaycong = ngaycong;
        this.ngaytao = ngaytao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getMatienluong() {
        return matienluong;
    }

    public void setMatienluong(int matienluong) {
        this.matienluong = matienluong;
    }

    public int getTienluong() {
        return tienluong;
    }

    public void setTienluong(int tienluong) {
        this.tienluong = tienluong;
    }

    public int getNgaycong() {
        return ngaycong;
    }

    public void setNgaycong(int ngaycong) {
        this.ngaycong = ngaycong;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }
    
    
}
