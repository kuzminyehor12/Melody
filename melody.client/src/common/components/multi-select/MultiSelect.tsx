import { Autocomplete, TextField } from "@mui/material";
import { useEffect, useState } from "react";
import { has } from "../../utils/stringUtils";

export interface Option {
    text: string;
    value: string;
}
  
interface MultiSelectProps {
    options: Option[];
    onChange: (event: React.ChangeEvent<{}>, selectedOptions: Option[]) => void;
    onClick: React.MouseEventHandler<HTMLDivElement>;
    value: Option[];
    label: string;
}

const MultiSelect: React.FunctionComponent<MultiSelectProps> = ({ options, onChange, onClick, value, label }) => {
    const [localOptions, setOptions] = useState<Option[]>([]);

    useEffect(() => {
      setOptions([...options]);
    }, [options])

    return (
      <Autocomplete
        style={{ marginTop: '12px' }}
        multiple
        options={localOptions}
        value={value}
        onChange={onChange}
        getOptionLabel={(option) => option.text}
        renderInput={(params) => (
          <TextField
            {...params}
            onClick={onClick}
            onChange={(e) => {
              if (!e.target.value) {
                setOptions([...options]);
              } else {
                let filteredOptions = localOptions.filter(o => has(o.text, e.target.value));
                setOptions([...filteredOptions]);
              }
            }}
            variant="outlined"
            label={label}
          />
        )}
      />
    );
  };

export default MultiSelect;