/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IHoaDonNhapService;
import com.btljava.daos.IHoaDonNhap;
import com.btljava.dao.impl.hoadonnhapDao;
import com.btljava.model.hoadonnhap;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class HoaDonNhapService implements IHoaDonNhapService{
    
    private IHoaDonNhap dao;
    
    public HoaDonNhapService(){
        dao = new hoadonnhapDao();
    }
    
    @Override
    public boolean insert(hoadonnhap hdn) throws Exception {
        return dao.insert(hdn);
    }

    @Override
    public boolean update(hoadonnhap hdn) throws Exception {
        return dao.update(hdn);
    }

    @Override
    public boolean delete(String hdn) throws Exception {
        return dao.delete(hdn);
    }

    @Override
    public List<hoadonnhap> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<hoadonnhap> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public hoadonnhap findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }
    
}
