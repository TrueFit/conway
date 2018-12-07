import * as React from "react";
import ReactTable, { Column, FinalState, Instance } from "react-table";
import "./InventoryGrid.css";
import "react-table/react-table.css";
import { DonutChart } from "../DonutChart/DonutChart";
import "coreComponents/DonutChart/DonutChart.css";
import "../Styles/Flexbox.css";

type Props = {
  Data: Inventory[];
  PageSize: number;
  TotalPages: number;
  PageNumber: number;
};

type DispatchProps = {
  OnPageSizeChange: (newPageSize: number, newPage: number) => {};
  OnPageChange: (page: number) => {};
};

type Inventory = {
  id: string;
  name: string;
  categoryId: number;
  categoryName: string;
  quality: Quality;
  sellIn: number;
  isLegendary: boolean;
  created: string;
  createdBy: number;
  modified?: string;
  modifiedBy?: string;
};

type Quality = {
  initial: number;
  current: number;
  max: number;
};

const columns: Array<Column<Inventory>> = [
  {
    Header: "Name",
    columns: [
      {
        Header: "Name",
        accessor: "name",
      },
      {
        Header: "Category",
        accessor: "categoryName",
      },
      {
        Header: "Quality",
        accessor: "quality",
        sortable: false,
        Cell: (row: { value: Quality }) => {
          const percentageValue = (row.value.max > 0 ? row.value.current / row.value.max : 0) * 100;
          const renderQuality = (text: string, value: number): JSX.Element => {
            const qualityStyle = {
              fontWeight: "bold",
              width: "50px",
              height: "20px"
            } as React.CSSProperties;
            return (
              <div className={"quality-item"}><span>{text}</span><span style={qualityStyle}>{value.toString()}</span></div>
            );
          };

          return (
            <div className="panelflex">
              <div className="panelflex panelrow" style={{ border: "none" }}>
                <div className="panelrow panelitem" style={{ flex: "0 0 50%" }}>
                  <section className={"quality-panel"}>
                    {renderQuality("Quality: ", row.value.current)}
                    {renderQuality("Initial Quality: ", row.value.initial)}
                    {renderQuality("Max Quality: ", row.value.max)}
                  </section>
                </div>
                <div className="panelrow panelitem" style={{ flex: "0 0 50%" }}>
                  <DonutChart
                    value={percentageValue}
                    size={70}
                    strokewidth={10}
                    averagePercent={100}
                    fontSize={12}
                  />
                </div>
              </div>
            </div>
          );
        },
      },
    ]

  }
];

export class InventoryGrid extends React.Component<Props & DispatchProps, undefined> {
  public componentWillMount(): void {
    //props.changeSearchTerm();
    //props.searchPatients();
    //props.getCounts();
  }

  public render(): JSX.Element {
    const data: Inventory[] = this.props.Data;
    return (
      <>
        <ReactTable

          loading={false}
          data={data}
          columns={columns}
          className="inventoryGrid -striped -highlight"
          collapseOnDataChange={false}
          collapseOnSortingChange={false}
          pageSize={this.props.PageSize}
          pages={this.props.TotalPages}
          onPageSizeChange={this.props.OnPageSizeChange}
          onPageChange={this.props.OnPageChange}
          manual={true}
          resizable={false}
          page={this.props.PageNumber - 1}
          previousText="Previous"
          nextText="Next"
          loadingText="Loading..."
          noDataText="No rows found"
          pageText="Page"
          ofText="of"
          rowsText="rows"
        >
          {(
            state: FinalState<Inventory>,
            makeTable: () => React.ReactChild,
            instance: Instance<Inventory>
          ) => {
            return (
              <div
                style={{
                  borderRadius: "5px",
                  overflow: "hidden",
                  padding: "5px",
                }}
              >
                {makeTable()}
              </div>
            );
          }}
        </ReactTable>
      </>
    );
  }
};
