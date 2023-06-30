/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.btljava.Service.Impl;

import com.btljava.Service.IBacSiService;
import com.btljava.daos.IBacSi;
import com.btljava.dao.impl.bacsiDao;
import com.btljava.model.bacsi;
import java.util.List;

/**
 *
 * @author ASUS
 */
public class BacSiService implements IBacSiService{

    private IBacSi bs;
    
    public  BacSiService(){
        bs = new bacsiDao();
    }
    
    @Override
    public boolean insert(bacsi nv) throws Exception {
        return bs.insert(nv);
    }

    @Override
    public boolean update(bacsi nv) throws Exception {
        return bs.update(nv);
    }

    @Override
    public boolean updates(bacsi nv) throws Exception {
        return bs.updates(nv);
    }

    @Override
    public boolean delete(String nv) throws Exception {
        return bs.delete(nv);
    }

    @Override
    public boolean deletes(String nv) throws Exception {
        return bs.deletes(nv);
    }

    @Override
    public List<bacsi> fiindAll() throws Exception {
        return bs.fiindAll();
    }

    @Override
    public List<bacsi> timkiem(String s) throws Exception {
        return bs.timkiem(s);
    }

    @Override
    public bacsi findby(String id) throws Exception {
        return bs.findby(id);
    }

    @Override
    public bacsi finbyid(int id) throws Exception {
        return bs.finbyid(id);
    }
    
}
