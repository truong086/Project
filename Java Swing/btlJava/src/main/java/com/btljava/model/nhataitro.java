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
public class nhataitro {
    int id;
    int manhataitro;
    String hoten;
    String ngaysinh;
    String diachi;
    String email;
    int gioitinh;
    String sodienthoai;
    String tinhtrangbenh;
    String taitro;
    String ngaytao;

    public nhataitro() {
    }

    public nhataitro(int id, int manhataitro, String hoten, String ngaysinh, String diachi, String email, int gioitinh, String sodienthoai, String tinhtrangbenh, String taitro, String ngaytao) {
        this.id = id;
        this.manhataitro = manhataitro;
        this.hoten = hoten;
        this.ngaysinh = ngaysinh;
        this.diachi = diachi;
        this.email = email;
        this.gioitinh = gioitinh;
        this.sodienthoai = sodienthoai;
        this.tinhtrangbenh = tinhtrangbenh;
        this.taitro = taitro;
        this.ngaytao = ngaytao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getManhataitro() {
        return manhataitro;
    }

    public void setManhataitro(int manhataitro) {
        this.manhataitro = manhataitro;
    }

    public String getHoten() {
        return hoten;
    }

    public void setHoten(String hoten) {
        this.hoten = hoten;
    }

    public String getNgaysinh() {
        return ngaysinh;
    }

    public void setNgaysinh(String ngaysinh) {
        this.ngaysinh = ngaysinh;
    }

    public String getDiachi() {
        return diachi;
    }

    public void setDiachi(String diachi) {
        this.diachi = diachi;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public int getGioitinh() {
        return gioitinh;
    }

    public void setGioitinh(int gioitinh) {
        this.gioitinh = gioitinh;
    }

    public String getSodienthoai() {
        return sodienthoai;
    }

    public void setSodienthoai(String sodienthoai) {
        this.sodienthoai = sodienthoai;
    }

    public String getTinhtrangbenh() {
        return tinhtrangbenh;
    }

    public void setTinhtrangbenh(String tinhtrangbenh) {
        this.tinhtrangbenh = tinhtrangbenh;
    }

    public String getTaitro() {
        return taitro;
    }

    public void setTaitro(String taitro) {
        this.taitro = taitro;
    }

    public String getNgaytao() {
        return ngaytao;
    }

    public void setNgaytao(String ngaytao) {
        this.ngaytao = ngaytao;
    }
    
    
    
}
