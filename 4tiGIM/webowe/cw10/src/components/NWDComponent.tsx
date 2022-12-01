import React from 'react'

type Props = {}

const NWDComponent = (props: Props) => {
    return (
        <>
            <div className='row mb-2'>
                <label className='col-3 text-end' htmlFor="a">Podaj a: </label>
                <input type="number" name="a" id="a" className='col-3' />
            </div>
            <div className='row mb-2'>
                <label className='col-3 text-end' htmlFor="b">Podaj b: </label>
                <input type="number" name="b" id="b" className='col-3' />
            </div>
            <div className='row mb-2'>
                <label className='col-3 text-end' htmlFor="b">Wybierz metodę: </label>
                <select  name="b" id="b" className='col-3' >
                    <option value="rec">Rekurencyjnie</option>
                    <option value="rec">Iteracyjnie</option>
                </select>
            </div>
            <div className="row mb-2">
                <input className='offset-3 col-3' type="button" value="Oblicz" />
            </div>
        </>
    )
}
export default NWDComponent;