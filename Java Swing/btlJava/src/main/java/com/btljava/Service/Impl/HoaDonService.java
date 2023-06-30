/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IHoaDonService;
import com.btljava.daos.IHoaDon;
import com.btljava.dao.impl.hoadonDao;
import com.btljava.model.hoadon;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class HoaDonService implements IHoaDonService{
    
    private IHoaDon dao;
    
    public HoaDonService(){
        dao = new hoadonDao();
    }

    @Override
    public boolean insert(hoadon hd) throws Exception {
        return dao.insert(hd);
    }

    @Override
    public boolean update(hoadon hd) throws Exception {
        return dao.update(hd);
    }

    @Override
    public boolean delete(String hd) throws Exception {
        return dao.delete(hd);
    }

    @Override
    public List<hoadon> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<hoadon> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public hoadon findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    @Override
    public List<hoadon> khachhang(String s) throws Exception {
        return dao.khachhang(s);
    }

    @Override
    public List<hoadon> sapxxep() throws Exception {
        return dao.sapxxep();
    }
    
}
