/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IChucVuService;
import com.btljava.Service.ICuocHenService;
import com.btljava.daos.ICuocHen;
import com.btljava.dao.impl.cuochenDao;
import com.btljava.model.chucvu;
import com.btljava.model.cuochen;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class CuocHenService implements ICuocHenService{
    private ICuocHen dao;
    
    public CuocHenService(){
        dao = new cuochenDao();
    }
    @Override
    public boolean insert(cuochen ch) throws Exception {
        return dao.insert(ch);
    }

    @Override
    public boolean update(cuochen ch) throws Exception {
        return dao.update(ch);
    }

    @Override
    public boolean delete(String ch) throws Exception {
        return dao.delete(ch);
    }

    @Override
    public List<cuochen> findAll() throws Exception {
        return dao.findAll();
    }

    @Override
    public List<cuochen> timkiem(String s) throws Exception {
        return dao.timkiem(s);
    }

    @Override
    public cuochen findbyid(int s) throws Exception {
        return dao.findbyid(s);
    }

    
    
}
