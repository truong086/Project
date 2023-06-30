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
public class benhnhan {
    int id;
    int mabenhnhan;
    String hoten;
    String ngaysinh;
    String diachi;
    int gioitinh;
    String nhommau;
    String tinhtrang;
    int chucvu_id;
    int doituong_id;
    String ngayvao;

    public benhnhan() {
    }

    public benhnhan(int id, int mabenhnhan, String hoten, String ngaysinh, String diachi, int gioitinh, String nhommau, String tinhtrang, int chucvu_id, int doituong_id, String ngayvao) {
        this.id = id;
        this.mabenhnhan = mabenhnhan;
        this.hoten = hoten;
        this.ngaysinh = ngaysinh;
        this.diachi = diachi;
        this.gioitinh = gioitinh;
        this.nhommau = nhommau;
        this.tinhtrang = tinhtrang;
        this.chucvu_id = chucvu_id;
        this.doituong_id = doituong_id;
        this.ngayvao = ngayvao;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public int getMabenhnhan() {
        return mabenhnhan;
    }

    public void setMabenhnhan(int mabenhnhan) {
        this.mabenhnhan = mabenhnhan;
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

    public int getGioitinh() {
        return gioitinh;
    }

    public void setGioitinh(int gioitinh) {
        this.gioitinh = gioitinh;
    }

    public String getNhommau() {
        return nhommau;
    }

    public void setNhommau(String nhommau) {
        this.nhommau = nhommau;
    }

    public String getTinhtrang() {
        return tinhtrang;
    }

    public void setTinhtrang(String tinhtrang) {
        this.tinhtrang = tinhtrang;
    }

    public int getChucvu_id() {
        return chucvu_id;
    }

    public void setChucvu_id(int chucvu_id) {
        this.chucvu_id = chucvu_id;
    }

    public int getDoituong_id() {
        return doituong_id;
    }

    public void setDoituong_id(int doituong_id) {
        this.doituong_id = doituong_id;
    }

    public String getNgayvao() {
        return ngayvao;
    }

    public void setNgayvao(String ngayvao) {
        this.ngayvao = ngayvao;
    }
}
